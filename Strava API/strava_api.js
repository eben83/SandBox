


const authorization_link = "https://www.strava.com/oauth/token"

function GetActivities(res){

    Console.log(res)

    // const activities_link = 
    //     "https://www.strava.com/api/v3/athlete/activities?access_token=${res.access_token}"

    //     fetch(activities_link)
    //         .then((res) => console.log(res.json()))
}


function reAuthorize(){

    fetch(authorization_link,{
        method: 'post',
        headers: {
            'Accept': 'application/json, text/plain, */*',
            'Content-type' : 'application/json'
        },
        body: JSON.stringify({

            client_id: '45021',
            client_secret: 'c258cacbe62c5e597322479531b3211e5cacc844',
            grant_type: 'refresh_token',
            refresh_token: 'f28d1c1bdb4ca4b18b9df128891f4d16fd23e2c2'
        }) 
    }) .then(res => res.json())
        .then(res => GetActivities(res))
}

reAuthorize()