import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

interface Client {
  name: string;
  address: string;
  postCode: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  public clients: Client[] = [];

  constructor(private http: HttpClient) { }

  ngOnInit() {
    this.getClients();
  }

  getClients() {
    this.http.get<Client[]>('/Client').subscribe(
      (result) => {
        this.clients = result;
      },
      (error) => {
        console.error(error);
      }
    );
  }

  updatePostIndex() {
    this.http.put<any>('/Client', {}).subscribe();
    this.getClients();
  }

  onFileSelected(event: any) {
    console.error(String(event.target.files[0].name));
    this.http.post<any>('/Client?path=' + String(event.target.files[0].name), {}).subscribe();
    this.getClients();
  }

  refresh() {
    this.getClients();
  }

  title = 'UI'
}
