pipeline {
    agent any

    stages {
        stage('Build') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    reuseNode true
                }
            }

            steps {
                echo 'Building the project...'
                sh 'dotnet build'
            }
        }

        stage('Tests') {
            agent {
                docker {
                    image 'mcr.microsoft.com/dotnet/sdk:8.0'
                    reuseNode true
                }
            }

            steps {
                echo 'Running tests...'
                sh 'dotnet test'
            }
        }

        stage('List Files') {
            steps {
                sh 'ls -la'
            }
        }
    }
}