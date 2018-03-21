import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';

@Component({
    selector: 'orderdetail',
    templateUrl: './orderdetail.component.html'
})
export class OrderDetailComponent {
    public customerOrderDetails: CustomerOrderDetailDto[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/Order/GetCustomerOrderDetail').subscribe(result => {
            this.customerOrderDetails = result.json() as CustomerOrderDetailDto[];
        }, error => console.error(error));
    }
}

interface CustomerOrderDetailDto {
    orderId: number;
    productId: number;
    productName: string;
    unitPrice: number;
    quantity: number;
    discount: number;
    companyName: string;
    contactName: string;
    phone: string;
    orderDate: Date;
    requiredDate: Date;
    shippedDate: Date;
}


