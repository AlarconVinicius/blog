import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  search: string = '';
  constructor(private router: Router) { }

  ngOnInit(): void {
  }
  onSearch(){
    this.router.navigate([`receitas/busca/${this.search}`]);
    this.search = ''
  }
}
