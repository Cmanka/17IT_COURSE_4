using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using FastReport.Data.ConnectionEditors;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace FastReport.Data
{
  public class PostgresDataConnection : DataConnectionBase
  {
    private void GetDBObjectNames(string name, List<string> list)
    {
      DataTable schema = null;
      using (DbConnection connection = GetConnection())
      {
        connection.Open();
        schema = connection.GetSchema("Tables", new string[] { null, "public", null, name });
      }
      foreach (DataRow row in schema.Rows)
      {
        list.Add(row["TABLE_NAME"].ToString());
      }
    }

    public override string[] GetTableNames()
    {
      List<string> list = new List<string>();
      GetDBObjectNames("BASE TABLE", list);
      GetDBObjectNames("VIEW", list);
      return list.ToArray();
    }

    public override string QuoteIdentifier(string value, DbConnection connection)
    {
      return "\"" + value + "\"";
    }

    protected override string GetConnectionStringWithLoginInfo(string userName, string password)
    {
      NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder(ConnectionString);

      builder.UserName = userName;
      builder.Password = password;

      return builder.ToString();
    }

    public override DbConnection GetConnection()
    {
      return new NpgsqlConnection(ConnectionString);
    }

    public override DbDataAdapter GetAdapter(string selectCommand, DbConnection connection,
      CommandParameterCollection parameters)
    {
      NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(selectCommand, connection as NpgsqlConnection);
      foreach (CommandParameter p in parameters)
      {
        NpgsqlParameter parameter = adapter.SelectCommand.Parameters.Add(p.Name, (NpgsqlDbType)p.DataType, p.Size);
        parameter.Value = p.Value;
      }
      return adapter;
    }

    public override Type GetParameterType()
    {
      return typeof(NpgsqlDbType);
    }

    public override string GetConnectionId()
    {
      NpgsqlConnectionStringBuilder builder = new NpgsqlConnectionStringBuilder(ConnectionString);
      string info = "";
      try
      {
        info = builder.Database;
      }
      catch
      {
      }
      return "Postgres: " + info;
    }

    public override ConnectionEditorBase GetEditor()
    {
      return new PostgresConnectionEditor();
    }
  }
}
