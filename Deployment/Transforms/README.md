Transforms folder for environment-specific IaC parameter files

Structure created:

Deployment/
  Transforms/
  Dev/       -> parameters.json (Dev environment)
    QA/        -> parameters.json (QA environment)
    BETA/      -> parameters.json (Beta environment)
    Prod/      -> parameters.json (Production environment)

File format
- Each file is a simple JSON object containing key/value pairs your IaC templates can consume.
- These are examples/templates — replace values (especially connection strings and secrets) with your real values or reference Key Vault/secure pipeline variables.

Recommended usage
- Do NOT store secrets (connection strings, passwords) in plain JSON inside the repo. Use:
  - Azure Key Vault referenced from pipeline or
  - Azure DevOps Library variable groups with secret variables
- In your pipeline, load the appropriate parameters file based on the stage and pass them to your deployment step. For example, in a Bicep CLI or az deployment command you can use these files to populate template parameters.

Example (PowerShell) to view Prod parameters before deployment:

```powershell
Get-Content .\Deployment\Transforms\Prod\parameters.json | ConvertFrom-Json
```

If you'd like, I can:
- Convert these JSON files into ARM/Bicep parameter format (if you use ARM templates or Bicep) or into parameter files for Terraform.
- Add pipeline steps to the `DevOps/deploy.yml` to download and use the proper file per environment automatically.
