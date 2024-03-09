import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Post } from '../../types/Post';
import '../../index.css';

const PostList: React.FC = () => {
  const [posts, setPosts] = useState<Post[]>([]);

  useEffect(() => {
    axios.get<Post[]>('http://localhost:5025/api/Post')
      .then(response => {
        setPosts(response.data);
      })
      .catch(error => {
        console.error('Error fetching posts:', error);
      });
  }), [];

  return (
    <div className="post-list-container">
      <h2>Список постів</h2>
      <ul>
        {posts.map(post => (
          <li key={post.id} className="post-item">
            <h3 className="post-title">{post.title}</h3>
            <p className="post-description">{post.description}</p>
            <p className="post-date">Posted on: {post.postedOn}</p>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default PostList;