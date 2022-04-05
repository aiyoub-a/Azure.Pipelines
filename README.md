# Implement CI/CD Pipeline and Deploy an ASP.NET Core application with SQL Server database to Azure Cloud
In this example I created a simple ASP.NET Core web application with .net 6 and SQL Server database to hold user data in my local computer. Then I show you how to create a pipeline for countinues integration and countinues delivery (CI/CD Pipeline) and finaly, you understand how to migrate a already web application with SQL data on Azure cloud step by step.

## Status
[![Build Status](https://dev.azure.com/Aiyoub/Demo/_build?definitionId=3)](https://dev.azure.com/Aiyoub/Demo/_build?definitionId=3)

## Azure CI/CD Pipeline for automation build, test and deployment
As you know, Azure Pipelines is a method for automatically builds and tests code projects to make them available to others. It works with just about any language or project type. Azure Pipelines combines continuous integration (CI) and continuous delivery (CD) to test and build your code and ship it to any target. 

The starting point for configuring CI and CD for your applications is to have your source code in a version control system. Azure DevOps supports two forms of version control - GitHub and Azure Repos. Any changes you push to your version control repository will be automatically built and validated.


### Requirement
To use Azure Pipelines, you need:
- An organization in Azure DevOps.
- Source code stored in a version control system like GitHub
- YAML editor
 For more information see the link [YAML](https://docs.microsoft.com/en-us/azure/devops/pipelines/get-started/yaml-pipeline-editor?view=azure-devops)

### Automate tests, builds, and delivery
**Continuous integration (CI)** automates _tests and builds_ for your project. CI helps to catch bugs or issues early in the development cycle, when they're easier and faster to fix. Items known as artifacts are produced from CI systems. They're used by the continuous delivery release pipelines to drive automatic deployments.

**Continuous delivery (CD)** automatically _deploys and tests code_ in multiple stages to help drive quality. Continuous integration systems produce deployable artifacts, which include infrastructure and apps. Automated release pipelines consume these artifacts to release new versions and fixes to the target of your choice.

![image](https://user-images.githubusercontent.com/102185699/161806519-bb43d643-97b4-4d3b-9ce3-e77b9aab9fa7.png)

