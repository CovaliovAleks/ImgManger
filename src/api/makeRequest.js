import axios from "axios";

const API_ENDPOIND='https://localhost:7250';

export const makeRequest=(config)=>{
    config.url = '${API_ENDPOIND}/${config.url}';

    return axios(config);
};