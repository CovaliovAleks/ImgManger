import { useSelector } from "react-redux";
import Layout from "../../components/Layout";
import DetailedCard from "../../components/DetailedCard";

const MainPage = () =>{
    const state = useSelector(state => state);
    console.log(state, 'state');

    return(
    <Layout nickName="Aleks" id="2" avatarUrl={'/'}>
        <div>main page</div>
        <DetailedCard nick="Aleks" 
                        id={3} 
                        imUrl='https://i.pcmag.com/imagery/reviews/03n7pcJTflJrZcaCk6zj1cu-1.fit_scale.size_1028x578.v1623700260.jpg' 
                        likes={23} 
                        isLikedByYou={true} 
                        comments={[{key:1, text: 'Comment 1', userName: 'User 1'}, {key:2, text: 'Comment 2', userName: 'User 2'},
                                    {key:3, text: 'Comment 3', userName: 'User 2'}]}  />
    </Layout>
    );
};

export default MainPage;