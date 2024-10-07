pipeline {
    agent any

    stages {
        stage('Tests') {
            agent {
                docker {
                    image 'bitnami/dotnet-sdk'
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