pipeline {
    agent any
    stages {
        stage('Test') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                }
            }
            steps {
                sh 'ls -la'
            }
        }
    }
}