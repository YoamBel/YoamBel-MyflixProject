import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, View,Dimensions,TouchableOpacity,ActivityIndicator,ScrollView,Image } from 'react-native';
import ImagesSwiper from "react-native-image-swiper";
import CardInformationOfMovie from './FormeCard/CardInformationOfMovie'


const customImg = [
  'https://www.ledojomanga.com/bdd_local/upload/images/valkyrie-apocalypse-visuel-2.jpg',
  'https://wallpapercave.com/wp/wp6507378.jpg',
  'https://besthqwallpapers.com/Uploads/7-12-2019/114821/thumb2-4k-the-simpsons-homer-simpson-bart-simpson-marge-simpson.jpg',
  'https://wallpaperaccess.com/full/693403.png'
];

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

animeUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/anime'

const Anime = () =>{



  const [dataAnime , setDataAnime] = useState([])
  const dataAnime1 = []
  const dataAnime2 = []
  const dataAnime3 = []
  const dataAnime4 = []
  const dataAnime5 = []
  const dataAnime6 = []

  {
    for (var i = 0 ; i < dataAnime.length;i++)
    {
      if(i < 6){dataAnime1.push(dataAnime[i])}
      else if(i < 12 ){dataAnime2.push(dataAnime[i])}
      else if(i < 18){dataAnime3.push(dataAnime[i])}
      else if(i < 24){dataAnime4.push(dataAnime[i])}
      else if(i < 30){dataAnime5.push(dataAnime[i])}
      else{dataAnime6.push(dataAnime[i])}
    }
   
  }


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
            result.map(st=> arr.push(
              <TouchableOpacity onPress = {informationOfMovie}>
                <View style = {styles.image}>
                    <Image style={{width: 145, height: 210 ,borderColor: 'write'}} source={{uri: `data:image/image;base64,${st.Picture}`}}/>
                </View>
              </TouchableOpacity>
               
            ))
            setDataAnime(arr) 
                    
          },
          (error) => {
          alert(error);
          })
          //.finally(() => setLoading(false))
        
    },[])

    const informationOfMovie = () =>{
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
        result.map(st=> arr.push(
          <CardInformationOfMovie
            style = {styles.cardInformation}
            ID = {st.ID}
            Title = {st.Title}
            Categorie = {st.Categorie} 
            Picture = {st.Picture}
            Average = {st.Average} 
            Genre = {st.Genre} 
            TextDescription = {st.TextDescription}
            Link = {st.Link}/>
           
        ))
        setDataAnime(arr) 
                
      },
      (error) => {
      alert(error);
      })
      //.finally(() => setLoading(false))

    }

    return (
      <View style={styles.container}>
        <ScrollView>
        
          <ImagesSwiper 
              images={customImg}
              autoplay={true} 
              autoplayTimeout={2.5}
              showsPagination={false}
              width={width} 
              height={height - 550} 
            />
                <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Tendance</Text>
             <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime1}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Comedy Anime</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime2}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Anime serie</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime3}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Top Anime momment</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime4}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Actuality</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime5}
                </View>
            </ScrollView>
            <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>New Anime Add</Text>
            <ScrollView horizontal={true}>
                <View style={styles.movie}>
                    {dataAnime6}
                </View>
            </ScrollView>
        </ScrollView>
         
      </View>
    );
  }
  
  const styles = StyleSheet.create({
    container: {
      flex: 1,
      marginTop: 0,
      backgroundColor:'black'
    },
    movie:{
      display:'flex',
      flexDirection:"row",
      marginTop:10,
    },
    image:{
      paddingRight:10,
      paddingLeft:10
    },
  });
    
  
  export default  Anime;