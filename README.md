# K8s-Deployment

## Config:
### We need to create an image and put it in docker hub  

**docker** login  
**docker** build -t _n0tn1w/test:1.0.0_ .  
**docker** push _n0tn1w/test:1.0.0_  

### We need to tell kubectl which images to use  
_deploy.yml_  
cd..  
**kuebctl** apply -f _deploy.yml_  

_service.yml_  
cd..  
**kuebctl** apply -f _service.yml_  

## Portals:
- https://portal.azure.com/#home
- https://hub.docker.com/

## Helpfull commands:  
**docker** images  
**docker** rmi <IMAGE ID> 

**kubectl** get pods  
**kubectl** delete pod <pod-name>  
**kubectl** scale deployment <your_deployment_name> --replicas=0  
**kubectl** get svc  
**kubectl** delete svc <weather-api>  


## Sources:
- https://developer.hashicorp.com/terraform/tutorials/kubernetes/aks
- https://www.youtube.com/watch?v=cNlxPKy_NPA&t=627s&ab_channel=NickChapsas