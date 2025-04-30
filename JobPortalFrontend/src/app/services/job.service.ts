import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Job } from '../models/job.model';

@Injectable({
  providedIn: 'root'
})
export class JobService {

  constructor(private http: HttpClient) { }
  private apiUrl = 'http://localhost:5198/api/Job';

  getJobs(): Observable<Job[]>{
    return this.http.get<Job[]>(this.apiUrl);
  }


}
