
import http from 'k6/http';

export const options = {
    vus: 30,
    iterations: '10000',
};

export default function () {
    http.get('http://localhost:5000/');
}