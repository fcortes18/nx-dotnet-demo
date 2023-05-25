# NxDotnetDemo

## Workspace set up

Run `npm i -g @nrwl/cli` to install NX CLI globally

Run `npx create-nx-workspace@latest` to create a new workspace with the latest version, if it's not installed it'll ask to install first and then show the steps to create the workspace.

Choose `Integrate monorepo` option:

![screenshot](static/nx-1.PNG)

Choose `apps` option:

![screenshot](static/nx-2.PNG)

Set repository name (for this one was `nx-dotnet-repo`) and enable distributed cache if you want CI faster:

![screenshot](static/nx-3.PNG)

Run `npm i --save-dev @nx-dotnet/core` to add nx-dotnet plugin into the current workspace. Now you are able to add libaries and applications into your monorepo workspace. 

You can review README.md in `demo-initial` branch and create a sub-branch to see and follow a step by step example addings apps and libs.

You can take a look on `demo-final` branch to see the completed example after creating the resources.

## Generate an application

Run `nx g @nx-dotnet/core:app my-app` to generate an application.

When using Nx, you can create multiple applications and libraries in the same workspace.

## Generate a library

Run `nx g @nx-dotnet/core:lib my-lib` to generate a library.

Libraries are shareable across libraries and applications.

## Development server

Run `nx serve my-app` for a dev server. The app will automatically reload if you change any of the source files.

## Build

Run `nx build my-app` to build the project. The build artifacts will be stored in the `dist/` directory. Use the `--prod` flag for a production build.

## Serve

Run `nx serve my-app` to run a simple development server. This will watch for file changes and rebuild your project.

## Understand this workspace

Run `nx graph` to see a diagram of the dependencies of the projects.

## Remote caching

Run `npx nx connect-to-nx-cloud` to enable [remote caching](https://nx.app) and make CI faster.

## Further help

Visit the [Nx Documentation](https://nx.dev) and the [Nx Dotnet Documentation](https://www.nx-dotnet.com/) to learn more.