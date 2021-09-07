import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-votes-results',
  templateUrl: './votes-results.component.html',
  styleUrls: ['./votes-results.component.css']
})
export class VotesResultsComponent implements OnInit {

  public results: VotesResults[] | undefined;

  constructor(http: HttpClient) {
    http.get<VotesResults[]>('https://localhost:44353/api/home/results').subscribe(result => {
      this.results = result;
      for (let city of this.results) {
        let total = 0;
        for (let vote of city.candidates) {
          total += parseInt(vote.votes);
        }
        for (let vote of city.candidates) {
          vote.percentage = parseFloat((parseInt(vote.votes) / total).toFixed(2)) * 100 + '%';
        }
      }
      console.log(result);
    }, error => console.error(error));
  }
  ngOnInit(): void { }
}

interface VotesResults {
  name: string,
  candidates: Candidates[]
}

interface Candidates {
  name: string;
  votes: string;
  percentage: string;
}
