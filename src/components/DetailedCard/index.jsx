import { useState } from 'react';
import './style.css';
import UserBadge from '../UserBadge';
import Comment from '../Comment';

const DetailedCard = ({nick, avatarUrl, id, imUrl, likes, isLikedByYou, comments}) =>{
    const [isCommentShown, setCommentShown] = useState(false);

    const renderComments= () =>{
        if(comments.length > 2 && !isCommentShown)
        {
            const commentsForRender = [...comments];
            commentsForRender.splice(comments.length -2, 2);

            return(
                <>
                    <span className="cnDetailedCommentsTitle" onClick={()=>setCommentShown(true)}>Show still {comments.length - commentsForRender.length} comments</span>
                    {commentsForRender.map((comment) => <Comment {...comment} />)}
                </>
            )
        };

        return (comments.map((comment) => <Comment {...comment} />));
    };

    return(
        <div className="cnDetailedCardRoot">
            <div className="cnDetailedCardHeader">
                <UserBadge nickName={nick} avatarUrl={avatarUrl} id={id} />
            </div>
            <div>
                <img src={imUrl} className="cnDetailedCardImg" alt="details" />
            </div>
            <div>
                like comments
            </div>
            <div>
                noted {likes} people
            </div>
            <div className="cnDetailedCardComments">
                {renderComments()}
            </div>
            <textarea className="cnDetailedCardTextArea" />
        </div>
    );
};

export default DetailedCard;