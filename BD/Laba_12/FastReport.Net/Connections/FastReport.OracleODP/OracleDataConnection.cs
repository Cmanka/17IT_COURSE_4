using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Oracle.DataAccess.Client;
using FastReport.Data.ConnectionEditors;

namespace FastReport.Data
{
  public class OracleDataConnection : DataConnectionBase
  {
    private void GetDBObjectNames(string name, string columnName, List<string> list)
    {
      DataTable schema = null;
      using (DbConnection connection = GetConnection())
      {
        connection.Open();
        OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder(connection.ConnectionString);
        schema = connection.GetSchema(name, new string[] { builder.UserID, null });
      }
      foreach (DataRow row in schema.Rows)
      {
        list.Add(row[columnName].ToString());
      }
    }

    public override string[] GetTableNames()
    {
      List<string> list = new List<string>();
      GetDBObjectNames("Tables", "TABLE_NAME", list);
      GetDBObjectNames("Views", "VIEW_NAME", list);
      return list.ToArray();
    }

    public override string QuoteIdentifier(string value, DbConnection connection)
    {
      return "\"" + value + "\"";
    }

    protected override string GetConnectionStringWithLoginInfo(string userName, string password)
    {
      OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder(ConnectionString);

      builder.UserID = userName;
      builder.Password = password;

      return builder.ToString();
    }

    public override DbConnection GetConnection()
    {
      return new OracleConnection(ConnectionString);
    }

    public override DbDataAdapter GetAdapter(string selectCommand, DbConnection connection,
      CommandParameterCollection parameters)
    {
      OracleDataAdapter adapter = new OracleDataAdapter(selectCommand, connection as OracleConnection);
      foreach (CommandParameter p in parameters)
      {
        OracleParameter parameter = adapter.SelectCommand.Parameters.Add(p.Name, (OracleDbType)p.DataType, p.Size);
        parameter.Value = p.Value;
      }
      return adapter;
    }

    public override Type GetParameterType()
    {
      return typeof(OracleDbType);
    }

    public override int GetDefaultParameterType()
    {
      return (int)OracleDbType.Varchar2;
    }

    public override string GetConnectionId()
    {
      OracleConnectionStringBuilder builder = new OracleConnectionStringBuilder(ConnectionString);
      string info = "";
      try
      {
        info = builder.DataSource;
      }
      catch
      {
      }
      return "Oracle: " + info;
    }

    public override ConnectionEditorBase GetEditor()
    {
      return new OracleConnectionEditor();
    }
  
  }
}
