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
            
            environment {
                DOTNET_CLI_HOME = "/tmp/dotnet_tools"  // Set the tools directory to a path Jenkins can access
            }

            steps {
                sh 'ls -la'
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