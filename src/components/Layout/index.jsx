import Navbar from '../NavBar';
import './style.css';

const Layout = ({nickName, avatarUrl, id, children}) =>{
    return(
        <div className='cnLayoutRoot'>
            <Navbar nickName={nickName} avatarUrl={avatarUrl} id={id} />
            <div className='cnLayoutBody'>content: {children}</div>
        </div>
    );
};

export default Layout;