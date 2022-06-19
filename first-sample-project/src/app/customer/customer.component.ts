import { HttpClient } from '@angular/common/http';
import { ThisReceiver } from '@angular/compiler';
import { Component } from '@angular/core';
import { Customer } from './customer.model';

@Component({
 
  templateUrl: './customer.component.html',
  
})
export class CustomerComponent {

  constructor(public httpc:HttpClient){

  }
  title = 'first-sample-project';
  myname = 'sayali shewale'
  CustomerModel: Customer = new Customer();
  CustomerModels: Array<Customer> = new Array<Customer>();
  AddCustomer() {
    console.log(this.CustomerModel);
    //this.CustomerModels.push(this.CustomerModel);

     var customerdto={
      customerCode:this.CustomerModel.customerCode,
      customerName:this.CustomerModel.customerName,
      customerAmount:Number(this.CustomerModel.customerAmount),
     }

    this.httpc.post("https://localhost:44336/api/Customer", customerdto).subscribe(res=>this.Postsuccess(res),res=>this.PostError(res));
    this.CustomerModel = new Customer();
    
  }
  Postsuccess(res:any){
   console.log(res);
   this.getData();
  }
  PostError(res:any){
    console.log(res);
  }
  EditCustomer(input: Customer) {
    this.CustomerModel = input;
  }
  DeleteCustomer(input: Customer) {
    var index=this.CustomerModels.indexOf(input);
    this.CustomerModels.splice(index,1);
  }
   getData(){
    console.log("Hii");
    this.httpc.get("https://localhost:44336/api/Customer").subscribe(res=>this.Getsuccess(res),res=>this.GetError(res));
   }
   Getsuccess(input:any){
       this.CustomerModels=input;
   }
   GetError(input:any){
     console.log(input);
   }
}
