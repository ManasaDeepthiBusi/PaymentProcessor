DevOps pipelines for PaymentProcessor

Files in this folder:

- buildvalidation.yml  - CI pipeline: restore, build, test and publish artifacts
- deploy.yml           - Single multi-stage deploy pipeline: Dev -> QA -> Staging -> Prod

Quick configuration steps

1) Azure service connection
   - Go to Project Settings -> Service connections in Azure DevOps and create a connection to your Azure subscription.
   - Use the name of the service connection to set the `azureSubscription` variable in `deploy.yml` (replace <<AzureServiceConnectionName>>).

2) Create App Services / Environments
   - Create the Azure App Service instances for each environment (dev/qa/staging/prod) and note their names.
   - Set the `webAppNameDev`, `webAppNameQa`, `webAppNameStaging`, and `webAppNameProd` variables in `deploy.yml` accordingly.
   - In Azure DevOps, create Environments named `dev`, `qa`, `staging`, `prod` (Project -> Pipelines -> Environments).
   - Configure "Approvals and checks" on an environment (for example, `prod`) to require manual approval before deployment.

3) Pipeline wiring
   - Create a new pipeline in Azure DevOps and point it to `DevOps/buildvalidation.yml` for your CI build pipeline.
   - Create a second pipeline and point it to `DevOps/deploy.yml` for deployments, or use the UI to create a pipeline from the YAML file.

Notes & options

- You can change the pipelines to publish and consume build artifacts from the CI pipeline instead of publishing inside the deploy pipeline.
- For more secure variable management, store secrets and connection strings in pipeline variables or variable groups and link them to the pipeline.
- The YAML contains placeholders that you must replace with real values or override at pipeline runtime.
