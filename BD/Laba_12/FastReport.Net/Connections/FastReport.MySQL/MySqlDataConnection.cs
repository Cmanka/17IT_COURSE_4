using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using MySql.Data.MySqlClient;
using FastReport.Data.ConnectionEditors;
using System.Data;

namespace FastReport.Data
{
  public class MySqlDataConnection : DataConnectionBase
  {
    private void GetDBObjectNames(string name, List<string> list)
    {
      DataTable schema = null;
      using (DbConnection connection = GetConnection())
      {
        connection.Open();
        schema = connection.GetSchema(name);
      }
      foreach (DataRow row in schema.Rows)
      {
        list.Add(row["TABLE_NAME"].ToString());
      }
    }

    public override string[] GetTableNames()
    {
      List<string> list = new List<string>();
      GetDBObjectNames("Tables", list);
      GetDBObjectNames("Views", list);
      return list.ToArray();
    }

    public override string QuoteIdentifier(string value, DbConnection connection)
    {
      return "`" + value + "`";
    }

    protected override string GetConnectionStringWithLoginInfo(string userName, string password)
    {
      MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(ConnectionString);

      builder.UserID = userName;
      builder.Password = password;

      return builder.ToString();
    }

    public override DbConnection GetConnection()
    {
      return new MySqlConnection(ConnectionString);
    }

    public override DbDataAdapter GetAdapter(string selectCommand, DbConnection connection,
      CommandParameterCollection parameters)
    {
      MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand, connection as MySqlConnection);
      foreach (CommandParameter p in parameters)
      {
        MySqlParameter parameter = adapter.SelectCommand.Parameters.Add(p.Name, (MySqlDbType)p.DataType, p.Size);
        parameter.Value = p.Value;
      }
      return adapter;
    }

    public override Type GetParameterType()
    {
      return typeof(MySqlDbType);
    }

    public override string GetConnectionId()
    {
      MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder(ConnectionString);
      string info = "";
      try
      {
        info = builder.Database;
      }
      catch
      {
      }
      return "MySQL: " + info;
    }

    public override ConnectionEditorBase GetEditor()
    {
      return new MySqlConnectionEditor();
    }
  
  }
}
