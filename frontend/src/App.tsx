//Author: Nya Croft
//Section 004

import React from 'react';
import './App.css';
import Header from './Header';
import BowlerList from './Bowler/BowlerList';

//Main App component
function App() {
  return (
    <div className="App">
      <Header title="Bowling League Database" />
      <BowlerList />
    </div>
  );
}

export default App;
