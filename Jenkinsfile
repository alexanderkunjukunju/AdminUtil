pipeline{
	agent any
	stages {
		stage('Build') {
			dir ('AdminUtil')
			{
				steps 
				{
					bat "msbuild.exe AdminUtil.sln /nologo /nr:false  /p:platform=\"x64\" /p:configuration=\"Debug\" /t:clean;restore;rebuild"
				}
			}
		}
	}
}



