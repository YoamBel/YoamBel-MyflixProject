import React, { useState,useEffect } from 'react';
import { StyleSheet, Text, TextInput, View,Dimensions,ActivityIndicator,ScrollView,TouchableOpacity,Image } from 'react-native';




 const  CardSearch = (props) =>{


 

    return (
        <View style={styles.container}>
            <View>
                <Image style={{width: 50, height: 82.5,   borderTopLeftRadius: 15, borderColor: 'red'}} source={{uri: `data:image/image;base64,${props.Picture}`}}/>
            </View>
            <View>
                <Text style = {styles.title}> {props.Title}</Text>
            </View>
        </View>
       
    );
  }
  
  const styles = StyleSheet.create({
    container: {
        backgroundColor:'red',
        height:82.5,
        width:'100%',
        borderBottomColor:'black',
        flexDirection:'row'
        
    },

  });
  
  export default  CardSearch;