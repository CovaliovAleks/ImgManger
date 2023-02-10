import UserBadge from '../UserBadge';
import './style.css';

const DetailedCard = (userName, avatarUrl, userId, imgUrl) =>{
    return(
        <div>
            <div><UserBadge nickName={userName} avatarUrl={avatarUrl} id={userId} /></div>
            <div>
                <img src={imgUrl} />
            </div>
            <div>
                like comments
            </div>
            <div>
                noted 21 people
            </div>
            <div>
                comment
                comment
                comment
            </div>
            <textarea />
        </div>
    );
};

export default DetailedCard;