pipeline{
	agent any
	stages {
		stage("Clean up")
		{
			steps 
			{
				deleteDir()
			}
		}
		stage("Clone")
		{
			steps
			{
				sh "git clone https://github.com/alexanderkunjukunju/AdminUtil.git"
			}
		}
	}
}