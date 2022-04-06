import React, { useState,useEffect } from 'react';
import { StyleSheet,Button, Text, View,FlatList,ActivityIndicator,Dimensions,Image, ScrollView,TouchableOpacity } from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { AntDesign } from '@expo/vector-icons';

const {width} = Dimensions.get('window')
const {height} = Dimensions.get('window')

const CardItemSerie = (props) =>{


    favorieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/favorie'

    const [downLoadList , setDownLoad] = useState([])
    const [ valid , setvalid] = useState(true)
    const [ID , setID] = useState('')
    const [title , setTitle] = useState('')
    const onAddAndDeleteListInMovie = async () => {
        //downLoadList.push(props.Title)
       

        if(valid === false)
        {
            fetch(favorieUrl + '/' + props.ID, {
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
           
            setvalid(true)
        }
        else{
            let obj = {
                "ID" : props.ID,
                "Title" : props.Title,
                "Picture":props.Picture,
                "Link" : props.Link,
            }
            let response = await fetch(favorieUrl,{
                method:'POST',
                headers: {
                    'Content-Type': 'application/json'
                    // 'Content-Type': 'application/x-www-form-urlencoded',
                  },
                  body: JSON.stringify(obj)
            })
            let data = await response.json()
            setTitle(data.path)
            setvalid(false)
        }   
    }




    return (
        <View style = {styles.Item}>
                <View style = {styles.card}>
                    <View>
                        <Image style={{width: width, height: height - 550,/*borderTopRightRadius:30,borderTopLeftRadius:30,*/  borderWidth: 1, borderColor: 'black'}}  source={{uri: `data:image/image;base64,${props.Picture}`}}/> 
                    </View>              
                    <View>
                        <View style={styles.informationMovie} >
                            <View style={styles.titleAndBtnAdd}>
                                <Text style={styles.title}>{props.Title} :</Text>
                                <TouchableOpacity onPress={onAddAndDeleteListInMovie} style={styles.buttonMovie}>
                                    <Text style={styles.btnAdd}>{valid ? <Ionicons name="add-circle-outline" size={24} color="white" /> : <AntDesign name="check" size={24} color="white" /> }</Text>
                                    <Text style={styles.add}>Remind me</Text>
                                </TouchableOpacity>
                            </View>
                            <Text style={styles.SeasonEpisode}>Season : {props.NbSeason} , Episodes : {props.NbEpisode}</Text> 
                            <Text style={styles.txt}>{props.TextDescription}</Text>                      
                        </View>
                        <View style={styles.roundAndGenre}>
                                <View style={styles.round}></View>
                                <Text style={styles.genre}>{props.Genre}</Text>
                        </View>
                        
                    </View>              
                </View>                          
            </View> 
    )
}

const styles = StyleSheet.create({
    container: {},
    headContainer : {
        marginBottom:3,
    },
    titleAndBtnAdd:{
        display:'flex',
        flexDirection:'row',
        justifyContent:'space-between',
        marginTop:2,

    },
    card:{
       
    },
    informationMovie:{
        paddingLeft: 10,
        fontWeight:'bold',
        marginBottom:3,
        

    },
    title:{
        fontSize:20,
        fontWeight:'bold',
        color:'white',
        fontFamily:'sans-serif-medium'

    },
    buttonMovie:{
        paddingRight : 30,
        color:'white',

    },
    btnAdd:{
        paddingLeft:15,
        color:'white',
    },
    roundAndGenre:{
        flexDirection:'row',
        marginBottom:10,
    },
    genre:{
        fontSize : 12,
        marginLeft: 2,
        color:'white',
        fontFamily:'sans-serif-condensed'
    },
    SeasonEpisode :{
        fontSize:15,
        color:'white',
        fontFamily:'sans-serif-medium'
    },
    txt:{
        fontSize : 14,
        marginLeft: 18,
        color:'white',
        fontFamily:'sans-serif-thin'

    },
    add:{
        fontSize : 11,
        color:'white',
        fontFamily:'sans-serif-light'
    },
    round:{
        backgroundColor:'red',
        width:7,
        height:7,
        display:'flex',
        borderRadius:50,
        marginLeft: 18,

    },
    Item:{
   
    },
    

  });

export default CardItemSerie;