import React, { useState,useEffect } from 'react';
import { StyleSheet,
    Button, 
    Text, 
    View,
    FlatList,
    ActivityIndicator,
    Dimensions,
    Image, 
    ScrollView,
    TouchableOpacity,
    ImageBackground, 
    Alert} from 'react-native';
import { Ionicons } from '@expo/vector-icons';
import { AntDesign } from '@expo/vector-icons';
import { useNavigation } from '@react-navigation/native';

    const {width} = Dimensions.get('window')
    const {height} = Dimensions.get('window')

    favorieUrl = 'http://ruppinmobile.tempdomain.co.il/site07/api/favorie'

    const CardInformationOfSerie = (props) => {


        const [ valid , setvalid] = useState(true)
        const [ validBack , setvalidBack] = useState(true)
        const navigation = useNavigation()

        const SetVoteClass = (vote) => {
            if( vote >= 8 && vote <= 10){
                return <Text style = {styles.avGreen}>{vote}</Text>
            }
            else if(vote >= 5 && vote <= 7){
                return <Text style = {styles.avOrange}>{vote}</Text>
            }
            else if (vote >= 0 && vote <= 4){
                return <Text style = {styles.avRed}>{vote}</Text>
            }
            
    
        }
        
        const goToBack = () => {
            navigation.navigate("StackNav")
            setvalidBack(true)
        }

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
               
                valid = true
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
                Alert.alert("Downloading...")
                setTitle(data.path)
                valid = false

            }   
        }
      

        return (
            
                <View style = {styles.container}> 
                 <ImageBackground opacity={0.2} source={{uri: `data:image/image;base64,${props.Picture}`}}  resizeMode ="cover"  style = {styles.imageCover}>  
                    <Text style={styles.title}>{props.Title}</Text>    
                        <Text style = {styles.SE}>Season : {props.NbSeason}     Episodes : {props.NbEpisode}</Text>                 
                        <Text style={styles.average}>{SetVoteClass(props.Average)}</Text>               
                        <Text  style={styles.txt}>{props.TextDescription}</Text>
                        <View style={styles.roundAndGenre}>
                                    <View style={styles.round}></View>
                                    <Text style={styles.genre}>{props.Genre}</Text>
                        </View>
                        <View style = {styles.Add}>
                            <TouchableOpacity onPress={onAddAndDeleteListInMovie} style={styles.buttonMovie}>
                                <Text style={styles.btnAdd}>{valid ? <Ionicons name="add-circle-outline" size={20} color="white" />  : <AntDesign name="check" size={24} color="white" /> }</Text>
                                <Text style={styles.backAndAdd}>Add</Text>
                            </TouchableOpacity>
                            <TouchableOpacity onPress ={validBack ? goToBack : goToBack } style={styles.buttonMovie}>
                                <Text style={styles.btnAdd}><AntDesign name="back" size={20} color="white" /></Text>
                                <Text style={styles.backAndAdd}>Back</Text>
                            </TouchableOpacity>
                        </View> 
                        </ImageBackground>                  
                </View>
            
        );
    }
    const styles = StyleSheet.create({
        container: {
            width : 145,
            height: 210,
            //backfaceVisibility:'visible',
            backgroundColor:'#333',
            margin:4,
            justifyContent:'space-between'
            //position:'relative'
        },
        imageCover:{
           
            height:210,
            width:145,
            margin:4,
            justifyContent:'space-between',

        },
        Add:{
            flexDirection:'row-reverse',
            justifyContent:'space-between'
        },
        btnAdd:{
            paddingRight:10,
            color:'white',
        },
        title:{
            fontSize:15,
            fontWeight:'bold',
            color:'white',
            fontFamily:'sans-serif-medium',
            marginRight:7,
    
        },
        average:{
            marginLeft:7
        },
        avGreen:{
            color:'green'
        },
        avOrange:{
            color:'orange'
        },
        avRed:{
            color:'red'
        },
        txt:{
            fontSize : 11,
            marginLeft: 7,
            marginRight:7,
            color:'white',
            fontFamily:'sans-serif-thin'
    
        },
        round:{
            backgroundColor:'red',
            width:5,
            height:5,
            display:'flex',
            borderRadius:50,
            marginLeft: 7,
    
        },
        roundAndGenre:{
            flexDirection:'row',
        },
        genre:{
            fontSize : 10,
            color:'white',
            fontFamily:'sans-serif-condensed'
        },
        backAndAdd:{
            fontSize : 11,
            color:'white',
            fontFamily:'sans-serif-condensed'
        },
        SE:{
            color:'white',
            fontSize : 11,
        },
        
        
    })

    export default CardInformationOfSerie