pipeline{
	agent any
	stages 
	{
		stage("Clean up")
		{
			steps 
			{
				deleteDir()
			}
		}	
		stage('Build') 
		{
			steps 
			{
				bat "msbuild.exe AdminUtil.sln /nologo /nr:false  /p:platform=\"Any CPU\" /p:configuration=\"Debug\" /t:clean;restore;rebuild"
			}
		}
	}
}



