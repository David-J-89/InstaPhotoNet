import { Component, OnInit } from '@angular/core';
import { Photo } from '../../_models/photo';
import { PostService } from '../../_services/post.service';
import { AlertifyService } from '../../_services/alertify.service';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-photo-list',
  templateUrl: './photo-list.component.html',
  styleUrls: ['./photo-list.component.css']
})
export class PhotoListComponent implements OnInit {
  photos: Photo[];

  constructor(private postService: PostService, private alertify: AlertifyService) { }

  ngOnInit() {
    this.loadPosts();
  }

  loadPosts() {
    this.postService.getPosts().subscribe((photos: Photo[]) => {
      this.photos = photos;
    }, error => {
      this.alertify.error(error);
    });
  }
}

