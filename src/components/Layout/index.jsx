import './style.css';

const Layout = ({nickName, url, id, children}) =>{
    return(
        <div className='cnLayoutRoot'>
            <div>navbar</div>
            <div className='cnLayoutBody'>content: {children}</div>
        </div>
    );
};

export default Layout;