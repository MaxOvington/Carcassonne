import * as React from 'react';
import logo from './logo.svg';
import './App.css';
import Link from './components/Link';

function App() {
  const value = 10;
  const date = new Date(Date.now() - value * 60000);
  return (
    <div className='App'>
      <h2> Carcassonne App </h2>
    {date.toLocaleString()}
    </div>
  )
}

export default App;
