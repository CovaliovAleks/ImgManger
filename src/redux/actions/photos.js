import {api} from '../../api';
import { getPhotosFailed, getPhotosStarted, getPhotosSuccess } from "../actionCreators/photos";

export const getPhotos = ()=>{
    return async(dispatch)=>{
        try{
            const response = api.photos.getPhotos({
                        params: {
                            page:0,
                            limit: 5
                        },
            });
            dispatch(getPhotosSuccess((await response).data));
            
        }
        catch(error){
            dispatch(getPhotosFailed(error));
        }
    }
};