# Study Actions Windows
It is test for study actions with Windows



ToDo

	https://github.com/actions
	https://github.com/actions/setup-dotnet


	jobs:
	  build:
		runs-on: windows-latest
		steps:
		  - uses: actions/checkout@v2
		  - uses: actions/setup-dotnet@v1
		  - name: Build
			run: dotnet build
		  - name: Run tests
			run: dotnet test
