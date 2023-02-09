import UserBadge from '../UserBadge';
import './style.css';

const Navbar = ({nickName, avatarUrl, id}) =>{
    return(
        <div className='cnNavbarRoot'>
            <div className='cnNavbarWrapper'>
                <span>manager</span>
                <UserBadge nickName={nickName} avatarUrl={avatarUrl} id={id} />
            </div>
        </div>
    );
};

export default Navbar;