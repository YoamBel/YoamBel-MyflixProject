import React, { useState,useEffect } from 'react';
import { StyleSheet,Alert, Text, View,TouchableOpacity,ActivityIndicator,Linking,Image,Dimensions } from 'react-native';
import { AntDesign } from '@expo/vector-icons';
import { Zocial } from '@expo/vector-icons';
import { Feather } from '@expo/vector-icons';
import { useNavigation } from '@react-navigation/native';


const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')



favorieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/favorie'

const CardItemFavorie = (props) =>{
    
    const [valid , setValid] = useState(true)
    const navigation = useNavigation()

    const onDeleteMovieInList =  (id) => {
        
        id = props.ID

        fetch(favorieUrl + '/' + id, {
            method: 'DELETE',
            //body: JSON.stringify({id:7}),
            headers: new Headers({
            'accept': 'application/json; charset=UTF-8'
            })
        })
        .then(res => {
        console.log('res=', res);
        return res.json()})
        .then((result) => {
        console.log("delete", result);},
        (error) => {
        console.log("err post=", error);})

        setValid(false)
        Alert.alert("Uninstallation...")
        goToBack
       
        
    }
    
    const goToBack = () => {
        navigation.navigate("Download")
       
    }
    

    return (
        
        <View style = { valid ? styles.container : styles.container2 }>
            <View style = {styles.containerAll}>
                <View>
                    <Image style={{width: 100, height: 170,   borderTopLeftRadius: 15, borderColor: 'red'}} source={{uri: `data:image/image;base64,${props.Picture}`}}/>
                </View>
                <View style = {styles.Item}>
                    <View>
                        <Text style = {styles.title}> {props.Title}</Text>
                    </View>
                    <View style = {styles.delete}>
                        <TouchableOpacity onPress = {onDeleteMovieInList}  style = {styles.btndelete}>
                        <Feather name="x" size={24} color="red" />
                        </TouchableOpacity>
                    </View>
                    
                </View>
                
            </View>
            <TouchableOpacity   onPress={Linking.openURL(props.Link)}>
                <Text style = {styles.btnLink}><Zocial name="googleplay" size={15} color="black" />  Start</Text> 
            </TouchableOpacity>
                     
        </View> 
    );
  }
  
  const styles = StyleSheet.create({
    container: {
       width:'100%' ,  
       marginBottom:5,
    },
    container2: {
        width:'100%' ,  
        marginBottom:5,
        opacity:0.2,
     },
    containerAll:{
        flexDirection:'row',
        
        
    },
    Item : {
        display:'flex',
        flexDirection:'row',
        //alignItems:'center',
        justifyContent:'space-between',
        backgroundColor:'#1F1F1F',
        width:'75%',
        paddingTop:20,
        paddingBottom:20,
        
        borderTopRightRadius: 15,

    },
    title:{
        fontSize:20,
        fontWeight:'bold',
        color:'white',
        fontFamily:'sans-serif-medium'

    },
    delete:{
        paddingRight:15,
       
        
    },
    btndelete:{
        //opacity:0.1,
    },
    btnLink:{
        //marginTop:50,
        backgroundColor:'white',
        //marginBottom:50,
        borderBottomLeftRadius: 15,
        borderBottomRightRadius: 15,
        textAlign:'center',
        fontFamily:'sans-serif-condensed',
        fontWeight:'bold',
        height: 30,


    }

  });
  
  export default  CardItemFavorie;