import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms'; 
@Component({
  selector: 'app-add-job',
  imports: [RouterModule, CommonModule, FormsModule], 
  templateUrl: './add-job.component.html',
  styleUrls: ['./add-job.component.css'] 
})
export class AddJobComponent {

}
