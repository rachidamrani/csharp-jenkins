pipeline {
    agent any

    stages {
        stage('Tests') {
            agent {
                docker {
                    registryUrl 'https://registry-1.docker.io/'
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    reuseNode true
                }
            }

            steps {
                sh '''
                    ls -la
                '''
            }
        }
    }
}