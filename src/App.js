import { BrowserRouter, Route, Routes } from 'react-router-dom';
import './App.css';
import MainPage from './pages/MainPage';
import UserPage from './pages/UserPage';

const App = () =>{
  return (
    <BrowserRouter>
      <Routes>
        <Route path='/' element={<MainPage />} />
        <Route path='/:id' element={<UserPage />} />
      </Routes>
    </BrowserRouter>
  );
};

export default App;