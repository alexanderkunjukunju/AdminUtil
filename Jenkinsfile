pipeline{
	agent any
	stages {
		stage('Build') {
			steps 
			{
				bat "msbuild.exe AdminUtil/AdminUtil.sln /nologo /nr:false  /p:platform=\"x64\" /p:configuration=\"Debug\" /t:clean;restore;rebuild"
			}
		}
	}
}



