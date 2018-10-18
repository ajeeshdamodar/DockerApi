import { Component } from '@angular/core';
import { AppServices } from './app.services';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  providers: [AppServices]
})
export class AppComponent {
  title = 'DockerWeb';
  products: any[];
  constructor(private _service: AppServices) {
  }

  ngOnInit() {
      this._service.GetProducts().subscribe(resp => {
          this.products = resp.json(); 
          console.log( this.products);          
      });

      
  }

}
