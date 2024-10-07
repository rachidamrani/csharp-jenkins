pipeline {
    agent any
    stages {
        stage('Test') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    reuseNode true
                }
            }

            steps {
                sh 'ls -la'
            }
        }
    }
}