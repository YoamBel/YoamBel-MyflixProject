import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, View,SafeAreaView,ActivityIndicator,Dimensions,Image,ScrollView } from 'react-native';
import CardItemFavorie from './FormeCard/CardItemFavorie';

favorieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/favorie'
const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

const Download = (props) =>{

    
  const [dataFavorie , setDataFavorie] = useState([])
  useEffect(() => {
    fetch(favorieUrl , {
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
        result.map(st=> arr.push( <CardItemFavorie 
          ID = {st.ID}
          Title = {st.Title}
          Picture = {st.Picture} 
          Link = {st.Link}/>))
          
        setDataFavorie(arr) 
      },
      (error) => {
      alert(error);
      })
      .finally(() => setLoading(false))
    
      },[])



    return (
      <View style = {{backgroundColor:'black'}}>
          <ScrollView>
           {dataFavorie}
           <Image style={{width: width, height: height}}  source={{uri:"https://ak.picdn.net/shutterstock/videos/1037353379/thumb/2.jpg" }}/> 
            </ScrollView>  
            
      </View>
    );
  }
  
  const styles = StyleSheet.create({
    container: {
      
    },
  });
  
  export default  Download;