# Create CI/CD Pipeline and Deploy an ASP.NET Core with SQL Server to Azure Cloud
In this example I created a simple ASP.NET Core web application with .net 6 and SQL Server database to hold user data in my local computer. Then I show you how to create a pipeline for countinues integration and countinues delivery (CI/CD Pipeline) and finaly, you understand how to migrate a already web application with SQL data on Azure cloud step by step.

### Status
[![Build Status](https://dev.azure.com/Aiyoub/AzurePipelines/_apis/build/status/aiyoub-a.Azure.Pipelines?branchName=Feature-A-documentation)](https://dev.azure.com/Aiyoub/AzurePipelines/_build/latest?definitionId=4&branchName=Feature-A-documentation)

## Azure CI/CD Pipeline for automation build, test and deployment
As you know, Azure Pipelines is a method for automatically builds and tests code projects to make them available to others. It works with just about any language or project type. Azure Pipelines combines continuous integration (CI) and continuous delivery (CD) to test and build your code and ship it to any target. 

The starting point for configuring CI and CD for your applications is to have your source code in a version control system. Azure DevOps supports two forms of version control - GitHub and Azure Repos. Any changes you push to your version control repository will be automatically built and validated.


### Requirement
To use Azure Pipelines, you need:
- An organization in _Azure DevOps_
- Source code stored in a version control system like _GitHub_
- _YAML_ editor
 For more information see the link [YAML](https://docs.microsoft.com/en-us/azure/devops/pipelines/get-started/yaml-pipeline-editor?view=azure-devops)

### Automate tests, builds, and delivery
**Continuous integration (CI)** automates _tests and builds_ for your project. CI helps to catch bugs or issues early in the development cycle, when they're easier and faster to fix. Items known as artifacts are produced from CI systems. They're used by the continuous delivery release pipelines to drive automatic deployments.

**Continuous delivery (CD)** automatically _deploys and tests code_ in multiple stages to help drive quality. Continuous integration systems produce deployable artifacts, which include infrastructure and apps. Automated release pipelines consume these artifacts to release new versions and fixes to the target of your choice.

![image](https://user-images.githubusercontent.com/102185699/161806519-bb43d643-97b4-4d3b-9ce3-e77b9aab9fa7.png)

### Define pipelines
* define pipeline using **YAML** syntax
  ![image](https://user-images.githubusercontent.com/102185699/161807622-f2892849-26f8-4aa8-9b18-8e07494a0d1a.png)

* define pipelines using the **Classic Interface**
  ![image](https://user-images.githubusercontent.com/102185699/161807683-1fc64e4c-ff34-4a26-9166-a2b374fa6698.png)

In this example we used YAML editor to create pipeline. Please take a look at below step to create and config your pipeline:
 1. Sign in to your Azure DevOps organization and go to your project.
    
    ![image](https://user-images.githubusercontent.com/102185699/162272680-0c61f567-62c2-4841-a623-d8a768d23bf1.png)

 2. Go to Pipelines, and then select New pipeline.
    
    ![new-pipwline](https://user-images.githubusercontent.com/102185699/162272863-d3337db1-47a2-4346-8a12-189d550ad41a.png)

 3. Do the steps of the wizard by first selecting GitHub as the location of your source code.

    ![connect-github](https://user-images.githubusercontent.com/102185699/162272947-3bb5be53-0e91-4b4b-a7e9-01cfdfa81b4f.png)

 4. You might be redirected to GitHub to sign in. If so, enter your GitHub credentials.

 5. When you see the list of repositories, select your repository.
    
    ![select-repo](https://user-images.githubusercontent.com/102185699/162273110-ce64fbf8-e247-4c4e-a59e-c47203573a43.png)

 6. You might be redirected to GitHub to install the Azure Pipelines app. If so, select Approve & install.
 
 7. Azure Pipelines will analyze your repository and recommend the ASP.NET Core pipeline template.

    ![config-repo](https://user-images.githubusercontent.com/102185699/162273249-14d58a79-b2d5-4577-b90d-663c9f1187d7.png)
    
 8. When your new pipeline appears, take a look at the YAML to see what it does. When you're ready, select Save and run.
    
    ![yaml](https://user-images.githubusercontent.com/102185699/162273379-562c4f26-7199-4478-865e-0601509f0cec.PNG)

 9. You're prompted to commit a new azure-pipelines.yml file to your repository. After you're happy with the message, select Save and run again.

    ![run-yaml](https://user-images.githubusercontent.com/102185699/162273894-25a1a3a6-372a-4fda-8d05-1f0f7e18d6a3.PNG)
   
 10. When you're ready to make changes to your pipeline, select it in the Pipelines page, and then Edit the azure-pipelines.yml file.

 11. Final result

    ![build-job](https://user-images.githubusercontent.com/102185699/162275121-86d4917a-7fda-4bb6-b9c1-9b02dca0027c.PNG)
    
    Check build result like unit tests result

    ![test-result](https://user-images.githubusercontent.com/102185699/162275058-6ae0383a-1e33-4500-be71-a895ed8eaa3e.png)
   
For more details olease see [here](https://docs.microsoft.com/en-us/azure/devops/pipelines/create-first-pipeline?view=azure-devops&tabs=net%2Ctfs-2018-2%2Cbrowser)



## Deploy ASP.NET Core web application with database on Azure Cloud
In this part, I'm going to deploy the ASP.NET Core app to Azure App Service and connect to an Azure SQL Database.

### Set up the sample application from GitHub
To follow along with this tutorial, Download the Sample Project from the repository https://github.com/aiyoub-a/Azure.Pipelines or clone it using the Git command below:
```
git clone https://github.com/aiyoub-a/Azure.Pipelines.git
cd azure.pipelines
```
 ![webapp](https://user-images.githubusercontent.com/102185699/161817431-b6f8ce2c-7bb4-4aa2-8112-fee2f600a317.PNG)

### Create the App Service on Azure portal
In the Azure portal:
 1. Enter App Service in the search bar at the top of the Azure portal and select the App Services item that appears in the results.
   ![app-service-1](https://user-images.githubusercontent.com/102185699/161819526-0cae630d-45c0-48c2-a2d6-8f875c3cf81e.png)
 2. On the App Services page, select + Create
      
 3. On the Create Web App page, fill out the form as follows.
    - Resource Group → Select Create new and enter a name of _demo_.
    - Name → Enter a unique name of your choice, such as mywebsitename1. This App Service name must be unique across Azure.
    - Publish → Code
    - Runtime stack → .NET 6.0
    - Operating System → Windows
    - Region → Any Azure region near you.
    - App Service Plan → Select Create New and give your App Service plan a name of asp-demo-a2d6(F1).
    - Select Change size under Sku and size settings to select the App Service plan specifications. (In this example I use Azure free trial)
   
![image](https://user-images.githubusercontent.com/102185699/161824447-586d5ce6-33da-4711-9a5a-9a779e39e300.png)
