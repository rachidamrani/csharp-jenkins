pipeline {
    agent any

    stages {
        stage('Tests') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    reuseNode true
                }
            }

            steps {
                sh '''
                    echo "Running .NET tests"
                    dotnet test
                '''
            }
        }
    }
}