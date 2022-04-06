import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, View,SafeAreaView,Image,Dimensions,ActivityIndicator } from 'react-native';
import ListNewMovie from './ListNewMovie';

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

const News = (props) =>{
 
  const [isLoading , setLoading] = useState(false);
    return (
      <View style = {styles.container}>
         {isLoading ? (<ActivityIndicator size="large" color="red"/>
                ) : (
          <View>
               <ListNewMovie/>
               <Image style={{width: width, height: height}}  source={{uri:"https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/Image_noire.jpg/800px-Image_noire.jpg" }}/> 
          </View>
         
          )} 
         
      </View>
    );
}
  
  const styles = StyleSheet.create({
    container: {
     backgroundColor:'black'
    },
  });
  
  export default  News;