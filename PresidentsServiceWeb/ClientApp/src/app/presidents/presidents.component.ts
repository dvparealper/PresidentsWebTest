import { Component } from '@angular/core';
import { PresidentsService } from './presidents.service';

@Component({
  selector: 'app-presidents',
  templateUrl: './presidents.component.html',
  styleUrls: ['./presidents.component.css']
})
export class PresidentsComponent {
  public sort = 'desc';
  public presidents;

  constructor(private presidentsService: PresidentsService) {
    this.sortPresidents();
  }

  public sortPresidents() {
    let direction = 0;
    if (this.sort === 'asc') {
      this.sort = 'desc';
      direction = 1;
    } else {
      this.sort = 'asc';
    }

    this.presidentsService.getSortedPresidents(direction)
      .subscribe(data => this.presidents = data,
                 err => console.error(err));
  }
}
