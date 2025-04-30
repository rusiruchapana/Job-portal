import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { RouterModule } from '@angular/router';
import { Job } from '../../models/job.model';
import { JobService } from '../../services/job.service';

@Component({
  selector: 'app-job-list',
  imports: [CommonModule , RouterModule],
  templateUrl: './job-list.component.html',
  styleUrl: './job-list.component.css'
})
export class JobListComponent {
  
  jobs: Job[] = [];
  constructor(private jobService: JobService){}

  ngOnInit(): void{
    this.loadJobs();
    console.log(this.jobs);
  }


  loadJobs(): void {
    this.jobService.getJobs().subscribe({
      next: (data)=>{
        this.jobs = data;
      },
      error: (e)=> console.error(e)
    });
  }




}
