# ICD-10 ASP.NET Web API using PostgreSQL 
This is a web API made using ASP.NET and PostgreSQL as the database choice for its ease of use.

## Usage
This API has only one endpoint that is `http://localhost:{YOUR_LOCAL_HOST}/api/all` that will list all the ICD-10 Codes with key pair format of: `{code: {CODE}, description: {DESCRIPTION}}`. To use the API on your local machine, simply do the following:

```bash
git clone https://github.com/muthanii/icdAPI/edit
cd icdAPI/
dotnet start
```
