# DeployToAzure

Silly repo to play with deploying to Azure from GitHub using actions.

Want to focus on the challenges with deploying multiple items (web app 
and web functions) from a single repository. Most of the samples cover
only doing one but not both

Key Learnings:
- Publish Profile is the XML format that GitHub uses as a secret. You can download
and rotate them from the Deployment Center in the WebApp