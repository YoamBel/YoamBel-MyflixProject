import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, View,Dimensions,TouchableOpacity,ActivityIndicator,ScrollView,Image } from 'react-native';
import ImagesSwiper from "react-native-image-swiper";
import CardInformationOfSerie from './FormeCard/CardInformationOfSerie'


const customImg = [
  'https://images.wallpapersden.com/image/download/tom-ellis-new-lucifer-morningstar_bGxnbmWUmZqaraWkpJRmbmdlrWZlbWU.jpg',
  'https://images-na.ssl-images-amazon.com/images/I/91c9ZhHcZhL._RI_.jpg',
  'https://i.pinimg.com/originals/ca/70/f3/ca70f3176ea01a9472d555b33ef190a9.jpg',
  'https://wallpaperaccess.com/full/790319.png'
];

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

serieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/serie'

const Serie = () =>{

  const [isLoading , setLoading] = useState(true);
  const [dataSerie , setDataSerie] = useState([])

  const dataSerie1 = []
  const dataSerie2 = []
  const dataSerie3 = []
  const dataSerie4 = []
  const dataSerie5 = []
  const dataSerie6 = []

  {
    for (var i = 0 ; i < dataSerie.length;i++)
    {
      if(i < 6){dataSerie1.push(dataSerie[i])}
      else if(i < 12 ){dataSerie2.push(dataSerie[i])}
      else if(i < 18){dataSerie3.push(dataSerie[i])}
      else if(i < 24){dataSerie4.push(dataSerie[i])}
      else if(i < 30){dataSerie5.push(dataSerie[i])}
      else{dataSerie6.push(dataSerie[i])}
    }
   
  }

 
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
        result.map(st=> arr.push(
          <TouchableOpacity onPress = {informationOfMovie}>
                <Text style = {{height:1}}>{st.ID}</Text>
                <View style = {styles.image}>
                  <Image style={{width: 145, height: 210 ,borderColor: 'write'}} source={{uri: `data:image/image;base64,${st.Picture}`}}/>
                </View>
          </TouchableOpacity>
           
        ))
        setDataSerie(arr) 
                
      },
      (error) => {
      alert(error);
      })
      .finally(() => setLoading(false))
    
    },[])

    const informationOfMovie = () =>{
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
        result.map(st=> arr.push(
          <CardInformationOfSerie
            style = {styles.cardInformation}
            ID = {st.ID}
            Title = {st.Title}
            NbSeason = {st.NbSeason}
            NbEpisode = {st.NbEpisode}
            Categorie = {st.Categorie} 
            Picture = {st.Picture}
            Average = {st.Average} 
            Genre = {st.Genre} 
            TextDescription = {st.TextDescription}
            Link = {st.Link}/>
           
        ))
        setDataSerie(arr) 
                
      },
      (error) => {
      alert(error);
      })
      .finally(() => setLoading(false))

    }



   return (
    <View style={styles.container}>
      {isLoading ? (<ActivityIndicator size="large" color="red"/>
                ) : (
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
                {dataSerie1}
            </View>
        </ScrollView>
        <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Top Serie</Text>
        <ScrollView horizontal={true}>
            <View style={styles.movie}>
                {dataSerie2}
            </View>
        </ScrollView>
        <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Top Serie momment</Text>
        <ScrollView horizontal={true}>
            <View style={styles.movie}>
                {dataSerie3}
            </View>
        </ScrollView>
        <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Actuality</Text>
        <ScrollView horizontal={true}>
            <View style={styles.movie}>
                {dataSerie4}
            </View>
        </ScrollView>
        <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>Serie Fantstic</Text>
        <ScrollView horizontal={true}>
            <View style={styles.movie}>
                {dataSerie5}
            </View>
        </ScrollView>
        <Text style = {{color:'white',marginLeft:7,fontWeight:'bold',fontSize:17}}>New Serie Add</Text>
        <ScrollView horizontal={true}>
            <View style={styles.movie}>
                {dataSerie6}
            </View>
        </ScrollView>
    </ScrollView>)}
     
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
 cardInformation:{
  backfaceVisibility :'hidden'
}
});
 
  
export default  Serie;