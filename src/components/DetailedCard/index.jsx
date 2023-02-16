import UserBadge from '../UserBadge';
import './style.css';

const DetailedCard = ({nickName, avatarUrl, id, imUrl}) =>{
    return(
        <div className="cnDetailedCardRoot">
            <div className="cnDetailedCardHeader">
                <UserBadge nickName={nickName} avatarUrl={avatarUrl} id={id} />
            </div>
            <div>
                <img src="/" className="cnDetailedCardImg" alt="details" />
            </div>
            <div>
                like comments
            </div>
            <div>
                noted 21 people
            </div>
            <div className="cnDetailedCardComments">
                comment
                comment
                comment
            </div>
            <textarea className="cnDetailedCardTextArea" />
        </div>
    );
};

export default DetailedCard;