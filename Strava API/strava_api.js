
https://www.strava.com/oauth/token?client_id=45021&client_secret=c258cacbe62c5e597322479531b3211e5cacc844&code=d7b1f2bf90b59a1bb636978fb8147c6b6fe425b6&grant_type=authorization_code

const activities_link = 
        "https://www.strava.com/api/v3/athlete/activities?access_token=ec2ef468b303dce39d6a1fd31ac02c6b3831442b"

const authorizeation_link = "https://www.strava.com/oauth/token"

function GetActivities(){
   
        fetch(activities_link)
            .then((res) => console.log(res.json()))
}

GetActivities()

function reAuthorize(){


}