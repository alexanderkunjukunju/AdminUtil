pipeline{
	agent any
	stages 
	{
		stage('Build') 
		{
			steps 
			{
				bat "msbuild.exe AdminUtil.sln /nologo /nr:false  /p:platform=\"Any CPU\" /p:configuration=\"Release\" /t:clean;restore;rebuild"
			}
		}
	}
}



