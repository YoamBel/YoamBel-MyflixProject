import React, { useState,useEffect } from 'react';
import { 
    StyleSheet,
    Button, 
    Text, 
    View,
    FlatList,
    ActivityIndicator,
    Dimensions,
    Image, 
    ScrollView,
    TouchableOpacity 
} from 'react-native';
import CardItemMovie from './FormeCard/CardItemMovie'
import CardItemSerie from './FormeCard/CardItemSerie'
//import DownLoad from './Download'


movieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/movie'
serieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/serie'
animeUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/anime'

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')


const ListNewMovie = (props) => {

    const [isLoading , setLoading] = useState(true);
    const [dataMovie , setDataMovie] = useState([])
    const [dataSerie , setDataSerie] = useState([])
    const [dataAnime , setDataAnime] = useState([])


    
    //concat
    //const dataAll = dataMovie.concat(dataSerie.concat(dataAnime))
    const dataAll = []
    {
        for (var i = 0 ; i < dataMovie.length;i++)
        {
            if(i < 6){dataAll.push(dataAnime[i])}
            else if(i < 12 ){dataAll.push(dataMovie[i])}
            else if(i < 18){dataAll.push(dataSerie[i])}
        }
    }

    //random
    const ListRandomData =[]
    {
        for (var i = 0; i < 50 ; i++)
        {
            ListRandomData.push(dataAll[Math.floor(Math.random()*dataAll.length)])
        }
    }
    //const [addInDownload , setAddInDownload] = useState([])

    
    
// Movie
    useEffect(() => {
        fetch(movieUrl , {
            method:'GET',
            headers : new Headers({
                'Content-Type':'application/json;charset=UTF-8'
            })
        })
        .then( res => {
            return res.json()
        })
        .then((result) => {
            let arr = []
           
            result.map(st=> arr.push(
            <CardItemMovie 
            ID = {st.ID}
            Title = {st.Title}
            Categorie = {st.Categorie} 
            Picture = {st.Picture} 
            Genre = {st.Genre} 
            TextDescription = {st.TextDescription}
            Link = {st.Link}/>
            ))
            setDataMovie(arr) 
                    
          },
          (error) => {
          alert(error);
          })
          .finally(() => setLoading(false))
        
    },[])
//Serie
    useEffect(() => {
        fetch(serieUrl , {
            method:'GET',
            headers : new Headers({
                'Content-Type':'application/json;charset=UTF-8'
            })
        })
        .then( res => {
            return res.json()
        })
        .then((result) => {
            let arr = []
            let arrID =[]

            result.map(st=> {
                arr.push(
            <CardItemSerie 
            ID = {st.ID}
            Title = {st.Title} 
            Picture = {st.Picture}
            Genre = {st.Genre} 
            TextDescription = {st.TextDescription} 
            Categorie = {st.Categorie} 
            NbSeason = {st.NbSeason}
            NbEpisode = {st.NbEpisode}
            Link = {st.Link}/>
            )
            })               
            setDataSerie(arr)
        },
        (error) => {
        alert(error);
        })
        .finally(() => setLoading(false))
        
    },[])
//Anime
    useEffect(() => {
        fetch(animeUrl , {
            method:'GET',
            headers : new Headers({
                'Content-Type':'application/json;charset=UTF-8'
            })
        })
        .then( res => {
            return res.json()
        })
        .then((result) => {
            let arr = []
            let arrID = []
            result.map(st=> arr.push(
            <CardItemMovie  
            ID = {st.ID}
             Title = {st.Title} 
             Picture = {st.Picture} 
             Genre = {st.Genre} 
             Categorie = {st.Categorie} 
             TextDescription = {st.TextDescription}
             Link = {st.Link}/>
            ))
            setDataAnime(arr)
            
            result.map(st=> arrID.push(st.ID))
            setDataIDAnime(arrID)
          },
          (error) => {
          alert(error);
          })
          .finally(() => setLoading(false))
        
    },[])

    
    
    

    
    return(
        <View style = {styles.container}>
            {isLoading ? (<ActivityIndicator/>
                ) : (
            <View>
                {<ScrollView>              
                    {dataAll}                   
                </ScrollView>}
            </View>
            
        
        )}
        </View>
      
    )
}

const styles = StyleSheet.create({
    container: {},
  });

export default ListNewMovie;




/*const  defaultState = []
export const movieList = (state = defaultState , action) => {

    switch(action.type){
        default:
            state
    }



     <View onPress={st.Link} style={styles.buttonMovie}>
                        <AntDesign name="forward" size={20} color="black" />
                        <Text style={styles.buttonText}>Start</Text>
                    </View>


    buttonMovie:{
        flexDirection:'row', 
        backgroundColor:'red' ,
        height:35,  
        width:100,  
        justifyContent:'center',
        alignItems:'center' 
    },
    buttonText:{
        marginLeft:4,
        fontWeight:'bold',
        
        
    }
}*/