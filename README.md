# K8s-Deployment

## Config:
We need to create an image and put it in docker hub

- docker login
- docker build -t n0tn1w/test:1.0.0 .
- docker push n0tn1w/test:1.0.0

We need to tell kubectl which images to use
- deploy.yml
- cd..
- kuebctl apply -f deploy.yml

- service.yml
- cd..
- kuebctl apply -f service.yml

## Portals:
- https://portal.azure.com/#home
- https://hub.docker.com/

## Helpfull commands:
- docker images
- docker rmi <IMAGE ID> 

- kubectl get pods
- kubectl delete pod <pod-name>
- kubectl scale deployment <your_deployment_name> --replicas=0
- kubectl get svc
- kubectl delete svc <weather-api>


## Sources:
- https://developer.hashicorp.com/terraform/tutorials/kubernetes/aks
- https://www.youtube.com/watch?v=cNlxPKy_NPA&t=627s&ab_channel=NickChapsas