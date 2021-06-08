# QualitesT
For Cloning of project use path https://github.com/Juhih/QualitesT.git

 

The reports after execution of the project will be available at the location: BinDirectory\SpecFlowProject1\bin\Debug\netcoreapp3.1\TestReport

 

Improvements that can be considered while creating a project:

1.) Due to time crunch right now we have kept the webdriver, webdriver capabilities, reports and the common webdriver methods in the same project.

Thinking of the project in broader perspective we can keep those things in one separate project using the nuget of it in our project. This will reduce the efforts when any other separate project needs to be created in future. We will be already having the schema of the project ready and have to only create the feature and the step definition file. This will reduce the cost in future development and does not have to put extra efforts while creating the first one.

This will also give us an added advantage of maintaining. If the driver version is upgraded or any change needs to be made we only have to do the changes at one single location.



2.) Parallel testing : Parallel testing can be implemented which will help in reducing the execution time.

3.) Reports: Better reports can be created with better UI Interface.

4.) Accessibility testing: Nowadays accessibility testing is also important as part of UI testing. We can integrate the accessibility testing with our framework using the axe.js file.

5.) Use of soft asserts.

6.) Adding other drivers as well for testing.

7.) Pipeline execution.

